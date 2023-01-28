import React from "react";
import { Form } from "react-router-dom";
import { PostApiAction } from "../redux/action/action";
import { useDispatch } from "react-redux";
import PostHeader from "./PostHeader";
import "./Form.css";
import ThumbUpIcon from "@material-ui/icons/ThumbUp";
import GetDetailsByHooks from "../hooks/getDetailsById";
import { useParams } from "react-router-dom";
import { useEffect } from "react";
import { useState } from "react";
import { useSelector } from "react-redux";
import { red } from "@material-ui/core/colors";
const ViewBlog = () => {
  const id = useParams();
  const [LikeCount, setLikeCount] = useState(0);
  console.log("Parama id is:", id);
  const [Title, setTitle] = useState("");
  const [Category, setCategory] = useState("");
  const [Description, setDescription] = useState("");

  const [detailsById] = GetDetailsByHooks(id);
  console.log("Details By ID*****************", detailsById);
  useEffect(() => {
    const data = () => {
      if (detailsById.data) {
        setTitle(detailsById.data.Title);
        setCategory(detailsById.data.Category);
        setDescription(detailsById.data.Description);
      }
    };
    data();
  }, [detailsById]);
  return (
    <div style={{backgroudColor:red}}>
      <PostHeader />
      <div class="card">
        <div class="card-header">Blog</div>
        <div class="card-body">
          <blockquote class="blockquote mb-0">
            <div>
              <h1>{Title}</h1>
            </div>
            <div>
              <h3>{Category}</h3>
            </div>

            <footer class="blockquote-footer">{Description}</footer>
          </blockquote>
        </div>
      </div>

      <h3>Like</h3>
      <div
        onClick={() => setLikeCount(LikeCount + 1)}
        style={{
          display: "flex",
          justifyContent: "center",
          gap: "9px",
          alignItems: "center",
        }}
      >
        <ThumbUpIcon></ThumbUpIcon>
        <span>{LikeCount}</span>
      </div>
    </div>
  );
};
export default ViewBlog;

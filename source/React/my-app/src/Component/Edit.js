import React from "react";
import { Form } from "react-router-dom";
import { EditApiAction } from "../redux/action/action";
import { useDispatch, useSelector } from "react-redux";
import { useEffect } from "react";
import PostHeader from "./PostHeader";
import "./Form.css";
import { useState } from "react";
import { useParams } from "react-router-dom";
import GetDetailsByHooks from "../hooks/getDetailsById";
import Reducer from "../redux/reducer/reducer";
const Edit = () => {
  const id = useParams();
  console.log("Parama id is:", id);
  const [Title, setTitle] = useState("");
  const [Category, setCategory] = useState("");
  const [Description, setDescription] = useState("");

  const isResponse=useSelector((state)=>state.reducer.isEditResponse);
  if(isResponse)
  {
    alert("Succesfully Edit!!!!");
  }

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

  const TitleHandler = (event) => {
    setTitle(event.target.value);
  };

  const CategoryHandler = (event) => {
    setCategory(event.target.value);
  };
  const DescriptionHandler = (event) => {
    setDescription(event.target.value);
  };
  const dispatch = useDispatch();

  const ClickHandler = (event) => {
    event.preventDefault();
    const finalData = {
      Title: Title,
      Category: Category,
      Description: Description,
    };
    console.log(finalData);
    dispatch(EditApiAction(finalData,id));
  };

  return (
    <div>
      <PostHeader />
      <Form className="pp" onSubmit={ClickHandler}>
        <div className="xx">
          <label>
            Name:
            <input
              type="text"
              onChange={(event) => {
                TitleHandler(event);
              }}
              defaultValue={Title}
            />
          </label>
        </div>

        <div className="xx">
          <label>
            Category:
            <input
              type="text"
              defaultValue={Category}
              onChange={(event) => {
                CategoryHandler(event);
              }}
            />
          </label>
        </div>

        <div className="xx">
          <label>
            Description:
            <textarea
              type="text"
              defaultValue={Description}
              onChange={(event) => {
                DescriptionHandler(event);
              }}
            ></textarea>
          </label>
        </div>

        <div>
          <button class="btn btn-primary">Update</button>
        </div>
      </Form>
    </div>
  );
};
export default Edit;

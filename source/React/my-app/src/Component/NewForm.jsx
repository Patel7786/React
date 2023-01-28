import React from "react";
import { Form } from "react-router-dom";
import { PostApiAction } from "../redux/action/action";
import { useDispatch } from "react-redux";
import PostHeader from "./PostHeader";
import "./Form.css";
import { useState } from "react";
import { useSelector } from "react-redux";
const NewForm = () => {
  const [Title, setTitle] = useState("");
  const [Category, setCategory] = useState("");
  const [Description, setDescription] = useState("");

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
  const isResponce=useSelector((state)=>state.reducer.isResponse);
  if(isResponce)
  {
    alert("Congratulations Your Blog Posted Sucessfully!!!");
  }
  const ClickHandler = (event) => {
    event.preventDefault();
    const finalData = {
      Title: Title,
      Category: Category,
      Description: Description
    };
    console.log(finalData);
    dispatch(PostApiAction(finalData));
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
              
              onChange={(event) => {TitleHandler(event)}}
            />
          </label>
        </div>

        <div className="xx">
          <label>
            Category:
            <input
              type="text"
              
              onChange={(event) => {CategoryHandler(event)}}
            />
          </label>
        </div>

        <div className="xx">
          <label>
            Description:
            <textarea
              type="text"
              onChange={(event) => {
                DescriptionHandler(event);
              }}
            ></textarea>
          </label>
        </div>

        <div>
          <button class="btn btn-primary">Submit</button>
        </div>
      </Form>
    </div>
  );
};
export default NewForm;

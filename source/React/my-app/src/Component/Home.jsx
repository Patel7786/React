import React, { useEffect, useState } from "react";

import { GetApiAction, DeleteApiAction } from "../redux/action/action";
import { useDispatch, useSelector } from "react-redux";
import Header from "./Header";
import Reducer from "../redux/reducer/reducer";
import { applyMiddleware } from "redux";
import { Link, Outlet } from "react-router-dom";

const Home = () => {
  const dispatch = useDispatch();
  const responseData = useSelector((state) => state.reducer.details);
  const isDeleteResponce = useSelector(
    (state) => state.reducer.isDeleteResponse
  );
  if (isDeleteResponce) {
    alert("Your data Sucessfully Deleted....!!!!");
    window.location.reload(false);
  }
  console.log("Responce Data-------------------------", responseData);
  useEffect(() => {
    dispatch(GetApiAction());
  }, [dispatch]);

  const result = responseData?.map((data, index) => {
    return (
      <div class="card" style={{ margin: 10 }}>
        <div class="card-body">
          {data.Title}
          <div>
            <Link to={`/Edit/${data.id}`} style={{ marginLeft: 300 }}>
              <i className="material-icons">&#xe22b;</i>{" "}
            </Link>{" "}
            <Link to={`/ViewBlog/${data.id}`} style={{ marginLeft: 30 }}>
              View Blog
            </Link>{" "}
            <span
              className="material-icons"
              style={{ marginLeft: 30 }}
              onClick={() => dispatch(DeleteApiAction(data.id))}
            >
              delete
            </span>
          </div>
        </div>
      </div>
    );
  });
  return (
    <div>
      <Header />
      {result}
      <Outlet />
    </div>
  );
};
export default Home;

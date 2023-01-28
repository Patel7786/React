import NewForm from "./Component/NewForm";
import Edit from "./Component/Edit";
import React from "react";
import Home from "./Component/Home";
import ViewBlog from "./Component/ViewBlog";
import {
  createBrowserRouter,
  createRoutesFromElements,
  Route,
  RouterProvider,
} from "react-router-dom";

const BlogPostForm = () => {
  const router = createBrowserRouter([
    {
      path: "/",
      element: <Home />,
    },{
      path: "/NewForm",
      element: <NewForm />
    },
    {
      path:"/Edit/:id",
      element:<Edit/>
    },
    {
      path:"/ViewBlog/:id",
      element:<ViewBlog/>
    }
  ]);
  return <RouterProvider router={router} />
  /*
  return (
    <div className="App">
      <Routes>
        <Route exact path="/" element={<Home />}></Route>
        <Route exact path="/NewForm" element={<NewForm />}></Route>
      </Routes>
    </div>
  );*/
};

export default BlogPostForm;

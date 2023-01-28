import axios from "axios";
export async function AxiosRequest(url, method, headers, params) {
  return params
    ? axios({
        url: url,
        method: method,
        headers: headers,
        data: params,
      })
    : axios({
        url: url,
        method: method,
        headers: headers,
        data: {},
      });
}

const GetApiDetails = () => {
  const headers = {
    "content-type": "application/json",
  };
  return AxiosRequest("http://localhost:3000/details", "GET", headers, {});
};

const PostApiDetails = (data) => {
  const headers = {
    "content-type": "application/json",
  };
  console.log("Inside APi Details", data);

  return AxiosRequest("http://localhost:3000/details", "POST", headers, data);
};

const GetDetailsById = (id) => {
  const headers = {
    "content-type": "application/json",
  };
  console.log("Inside APi id", id);
  var num = id.id;
  return AxiosRequest(
    "http://localhost:3000/details/" + num,
    "GET",
    headers,
    {}
  );
};

const EditApiDetails = (data, id) => {
  const headers = {
    "content-type": "application/json",
  };
  console.log("Inside APi Details", data, id);

  return AxiosRequest(
    "http://localhost:3000/details/" + id.id,
    "PUT",
    headers,
    data
  );
};

const DeleteApiDetails = (id) => {
    const headers = {
      "content-type": "application/json",
    };
    console.log("Inside APi Details",  id);
  
    return AxiosRequest(
      "http://localhost:3000/details/" + id,
      "DELETE",
      headers,
      {}
    );
  };

export { GetApiDetails, PostApiDetails, GetDetailsById, EditApiDetails,DeleteApiDetails };

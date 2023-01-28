import React, { useEffect, useState } from "react";
import { GetDetailsById } from "../api/axiosRequest";

export default (props) => {
  const [DetailsById, setDetailsById] = useState({});
  const GetDetailsByHooks = (requestId) => {
    console.log("Request Id---------------",requestId);
    return GetDetailsById(requestId).then((res) => {
      console.log("Responce data from get Details By ID-----------", res);
      setDetailsById(res);
    });
  };
  useEffect(() => {
    GetDetailsByHooks(props);
  }, []);
 
  return [DetailsById];
};

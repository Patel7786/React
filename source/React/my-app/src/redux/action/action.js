import { GET_DETAILS, POST_DETAILS ,EDIT_DETAILS,DELETE_DETAILS} from "../type";
import { GetApiDetails, PostApiDetails,EditApiDetails ,DeleteApiDetails} from "../../api/axiosRequest";
const GetApiAction = () => {
  return function (dispatch) {
    return GetApiDetails().then((res) => {
      console.log("Responce data from-----------", res);
      dispatch({
        type: GET_DETAILS,
        payload: res.data,
      });
    });
  };
};

const PostApiAction = (request) => {
  console.log(request);
  return function (dispatch) {
    dispatch({
        type: POST_DETAILS,
        payload: false,
      });
    return PostApiDetails(request).then((res) => {
      console.log("Responce data from-----------", res);
      dispatch({
        type: POST_DETAILS,
        payload: true,
      });
    });
  };
};

const EditApiAction = (request, id) => {
  console.log(request, id);
  return function (dispatch) {
    dispatch({
      type: EDIT_DETAILS,
      payload: false,
    });
    return EditApiDetails(request, id).then((res) => {
      console.log("Responce data from-----------", res);
      dispatch({
        type: EDIT_DETAILS,
        payload: true,
      });
    });
  };
};

const DeleteApiAction = (request, id) => {
    console.log(request, id);
    return function (dispatch) {
      dispatch({
        type: DELETE_DETAILS,
        payload: false,
      });
      return DeleteApiDetails(request, id).then((res) => {
        console.log("Responce data from-----------", res);
        dispatch({
          type: DELETE_DETAILS,
          payload: true,
        });
      });
    };
  };
export { GetApiAction, PostApiAction, EditApiAction,DeleteApiAction };

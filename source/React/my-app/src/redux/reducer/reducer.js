import {
  GET_DETAILS,
  POST_DETAILS,
  EDIT_DETAILS,
  DELETE_DETAILS,
} from "../type";

const initialState = {
  details: [],
  detailsById: [],
  isResponse: false,
  isEditResponse: false,
  isDeleteResponse: false,
};

const Reducer = (state = initialState, Action) => {
  switch (Action.type) {
    case GET_DETAILS:
      return { details: Action.payload };
    case POST_DETAILS:
      return { isResponse: Action.payload };
    case EDIT_DETAILS:
      return { isEditResponse: Action.payload };
    case DELETE_DETAILS:
      return { isDeleteResponse: Action.payload };
    default:
      return state;
  }
};

export default Reducer;

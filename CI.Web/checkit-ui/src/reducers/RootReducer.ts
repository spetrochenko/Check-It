import { combineReducers } from "redux";
import { BoardReducer } from "./board/BoardReducer";

export default combineReducers({
  board: BoardReducer
});

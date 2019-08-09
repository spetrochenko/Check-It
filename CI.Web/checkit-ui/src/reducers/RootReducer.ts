import { combineReducers } from "redux";
import { BoardReducer } from "./board/BoardReducer";
import { BoardListReducer } from "./board/BoardListReducer";
import { routerReducer } from "react-router-redux";

export default combineReducers({
  routing: routerReducer,
  board: BoardReducer,
  boardList: BoardListReducer
});

import { BoardListModel } from "../../models/models";
import {
  LOAD_BOARDS,
  LOAD_BOARDS_REQUEST,
  DELETE_BOARD
} from "../../actions/board/BoardActionConstants";

const initialState: BoardListModel = {
  boardList: [],
  isFetching: true
};

export const BoardListReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_BOARDS_REQUEST:
      return { ...state, isFetching: true };
    case LOAD_BOARDS:
      return { ...state, boardList: action.payload, isFetching: false };
    case DELETE_BOARD:
      return { ...state };
    default:
      return state;
  }
};

export default BoardListReducer;
import { CreateBoardViewModel } from "../../models/models";
import {
  LOAD_BOARDS,
  ADD_BOARD
} from "../../actions/board/BoardActionConstants";

const initialState: CreateBoardViewModel[] = [
  {
    title: "testBoard1"
  }
];

export const BoardListReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_BOARDS:
      const newState = action.payload;
      return newState;
    case ADD_BOARD:
      const newBoard = action.payload;
      return [...state, newBoard];
    default:
      return state;
  }
};

export default BoardListReducer;

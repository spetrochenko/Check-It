import {
  ADD_COLUMN,
  DRAG_HAPPENED,
  ADD_BOARD,
  LOAD_BOARDS
} from "./BoardActionConstants";
import {
  CreateColumnViewModel,
  CreateBoardViewModel
} from "../../models/models";
import {
  columnApiController,
  boardApiController
} from "../../server/apiDefenition";

export const AddNewColumn = (columnView: CreateColumnViewModel) => {
  return (dispatch: any) => {
    let columnController = new columnApiController();

    columnController.createColumn(columnView).then(response => {
      dispatch({
        type: ADD_COLUMN,
        payload: response.title
      });
    });
  };
};

export const AddNewBoard = (boardView: CreateBoardViewModel) => {
  return (dispatch: any) => {
    let boardController = new boardApiController();

    boardController.createBoard(boardView).then(response => {
      dispatch({
        type: ADD_BOARD,
        payload: response
      });
    });
  };
};

export const LoadBoards = () => {
  return (dispatch: any) => {
    let boardController = new boardApiController();

    boardController.loadBoards().then(response => {
      dispatch({
        type: LOAD_BOARDS,
        payload: response
      });
    });
  };
};

export const SortColumn = (
  droppableIdStart: any,
  droppableIdEnd: any,
  droppableIndexStart: any,
  droppableIndexEnd: any,
  draggableId: any
) => {
  return {
    type: DRAG_HAPPENED,
    payload: {
      droppableIdStart,
      droppableIdEnd,
      droppableIndexStart,
      droppableIndexEnd,
      draggableId
    }
  };
};

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
    columnApiController.createColumn(columnView).then(response => {
      dispatch({
        type: ADD_COLUMN,
        payload: response.title
      });
    });
  };
};

export const AddNewBoard = (boardView: CreateBoardViewModel) => {
  return (dispatch: any) => {
    boardApiController.createBoard(boardView).then(response => {
      dispatch({
        type: ADD_BOARD,
        payload: response
      });
    });
  };
};

export const LoadBoards = () => {
  return (dispatch: any) => {

    setTimeout(() => {
      boardApiController.loadBoards().then(response => {
        dispatch({
          type: LOAD_BOARDS,
          payload: response
        });
      });
    }, 2000);
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

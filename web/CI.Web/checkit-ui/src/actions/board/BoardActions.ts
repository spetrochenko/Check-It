import {
  ADD_COLUMN,
  DRAG_HAPPENED,
  ADD_BOARD,
  LOAD_BOARDS,
  LOAD_BOARDS_REQUEST,
  DELETE_BOARD
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
    boardApiController
      .createBoard(boardView)
      .then(response => {
        dispatch({
          type: ADD_BOARD,
          payload: response
        });
      })
      .then(() => {
        boardApiController.loadBoards().then(response => {
          dispatch({
            type: LOAD_BOARDS,
            payload: response
          });
        });
      });
  };
};

export const LoadBoards = () => {
  return (dispatch: any) => {
    dispatch({
      type: LOAD_BOARDS_REQUEST
    });

    boardApiController.loadBoards().then(response => {
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

export const DeleteBoard = (boardView: CreateBoardViewModel) => {
  return (dispatch: any) => {
    boardApiController
      .deleteBoard(boardView)
      .then(() => {
        dispatch({
          type: DELETE_BOARD
        });
      })
      .then(() => {
        boardApiController.loadBoards().then(response => {
          dispatch({
            type: LOAD_BOARDS,
            payload: response
          });
        });
      });
  };
};

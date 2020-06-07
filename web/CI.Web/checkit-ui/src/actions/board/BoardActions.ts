import {
  ADD_COLUMN,
  DRAG_HAPPENED,
  ADD_BOARD,
  LOAD_BOARDS,
  EDIT_TICKET,
} from "./BoardActionConstants";
import {
  CreateColumnViewModel,
  CreateBoardViewModel,
  TicketViewModel,
} from "../../models/models";
import {
  columnApiController,
  boardApiController,
} from "../../server/apiDefenition";

export const AddNewColumn = (columnView: CreateColumnViewModel) => {
  return (dispatch: any) => {
    dispatch({
      type: ADD_COLUMN,
      payload: columnView,
    });
  };
};

export const AddNewBoard = (boardView: CreateBoardViewModel) => {
  return (dispatch: any) => {
    dispatch({
      type: ADD_BOARD,
      payload: boardView,
    });
  };
};

export const LoadBoards = () => {
  return (dispatch: any) => {
    setTimeout(() => {
      boardApiController.loadBoards().then((response) => {
        dispatch({
          type: LOAD_BOARDS,
          payload: response,
        });
      });
    }, 2000);
  };
};

export const EditTicket = (ticket: TicketViewModel) => {
  return (dispatch : any) => {
    dispatch({
      type: EDIT_TICKET,
      payload: ticket,
    });
  }
}

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
      draggableId,
    },
  };
};

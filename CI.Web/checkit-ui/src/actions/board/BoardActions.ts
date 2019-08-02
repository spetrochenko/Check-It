import { ADD_COLUMN, ADD_TICKET, DRAG_HAPPENED } from "./BoardActionConstants";

export const AddNewColumn = (title: string) => {
  return {
    type: ADD_COLUMN,
    payload: title
  };
};

export const AddNewTicket = (columnId: number, title: string) => {
  return {
    type: ADD_TICKET,
    payload: { columnId, title }
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

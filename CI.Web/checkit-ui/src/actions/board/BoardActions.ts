import { ADD_COLUMN, DRAG_HAPPENED } from "./BoardActionConstants";
import { CreateColumnViewModel } from "../../models/models";
import { columnApiController } from "../../server/apiDefenition";

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

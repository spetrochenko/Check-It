import {
  BoardViewModel,
  ColumnViewModel,
  TicketViewModel
} from "../../models/models";
import {
  ADD_COLUMN,
  DRAG_HAPPENED
} from "../../actions/board/BoardActionConstants";

import { ADD_TICKET } from "../../actions/column/ColumnActionConstants";

let columnId = 0;
let ticketId = 0;

const initialState: BoardViewModel = {
  boardId: 0,
  title: "testBoard",
  columns: []
};

export const BoardReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case ADD_COLUMN:
      const newColumn: ColumnViewModel = {
        columnId: columnId,
        title: action.payload,
        tickets: []
      };
      columnId += 1;
      return { ...state, columns: [...state.columns, newColumn] };

    case ADD_TICKET: {
      const newTicket: TicketViewModel = {
        title: action.payload.title,
        creationDate: String(Date.now()),
        ticketId: String(ticketId)
      };
      ticketId += 1;

      const updateColumns = state.columns.map(column => {
        if (column.columnId === action.payload.columnId) {
          return {
            ...column,
            tickets: [...column.tickets, newTicket]
          };
        } else {
          return column;
        }
      });

      return { ...state, columns: updateColumns };
    }

    case DRAG_HAPPENED: {
      const {
        droppableIdStart,
        droppableIdEnd,
        droppableIndexStart,
        droppableIndexEnd
      } = action.payload;

      const newState = state;

      if (droppableIdStart === droppableIdEnd) {
        const column: any = state.columns.find(
          column => droppableIdStart == column.columnId
        );
        const ticket = column.tickets.splice(droppableIndexStart, 1);

        column.tickets.splice(droppableIndexEnd, 0, ...ticket);
      }

      if (droppableIdStart !== droppableIdEnd) {
        const columnStart: any = state.columns.find(
          column => droppableIdStart == column.columnId
        );
        const ticket = columnStart.tickets.splice(droppableIndexStart, 1);
        const columnEnd: any = state.columns.find(
          column => droppableIdEnd == column.columnId
        );

        columnEnd.tickets.splice(droppableIndexEnd, 0, ...ticket);
      }

      return newState;
    }

    default:
      return state;
  }
};

export default BoardReducer;

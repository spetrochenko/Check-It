import {
  BoardViewModel,
  ColumnViewModel,
  TicketViewModel,
} from "../../models/models";
import {
  ADD_COLUMN,
  DRAG_HAPPENED,
  EDIT_TICKET,
} from "../../actions/board/BoardActionConstants";

import { ADD_TICKET } from "../../actions/column/ColumnActionConstants";

let columnId = 2;
let ticketId = 8;

let today = new Date();
let dd = String(today.getDate()).padStart(2, "0");
let mm = String(today.getMonth() + 1).padStart(2, "0");
let yyyy = today.getFullYear();

let todayString = mm + "/" + dd + "/" + yyyy;

const initialState: BoardViewModel = {
  boardId: 1,
  title: "Start board",
  columns: [
    {
      columnId: 0,
      title: "Backlog",
      tickets: [
        {
          ticketId: "0",
          title: "ticket0",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
        {
          ticketId: "1",
          title: "ticket1",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
      ],
    },
    {
      columnId: 1,
      title: "Active",
      tickets: [
        {
          ticketId: "2",
          title: "ticket2",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
        {
          ticketId: "3",
          title: "ticket3",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
        {
          ticketId: "4",
          title: "ticket4",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
      ],
    },
    {
      columnId: 3,
      title: "Resolved",
      tickets: [
        {
          ticketId: "5",
          title: "ticket2",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
        {
          ticketId: "6",
          title: "ticket3",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
        {
          ticketId: "7",
          title: "ticket4",
          creationDate: todayString,
          description: "some description",
          type: "task",
        },
      ],
    },
  ],
};

export const BoardReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case ADD_COLUMN:
      const newColumn: ColumnViewModel = {
        columnId: columnId,
        title: action.payload,
        tickets: [],
      };

      return { ...state, columns: [...state.columns, newColumn] };

    case ADD_TICKET: {
      const newTicket: TicketViewModel = {
        title: action.payload.title,
        creationDate: todayString,
        ticketId: String(ticketId),
        description: "",
        type: "task",
      };
      ticketId += 1;

      const updateColumns = state.columns.map((column) => {
        if (column.columnId === action.payload.columnId) {
          return {
            ...column,
            tickets: [...column.tickets, newTicket],
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
        droppableIndexEnd,
      } = action.payload;

      const newState = state;

      if (droppableIdStart === droppableIdEnd) {
        const column: any = state.columns.find(
          (column) => droppableIdStart == column.columnId
        );
        const ticket = column.tickets.splice(droppableIndexStart, 1);

        column.tickets.splice(droppableIndexEnd, 0, ...ticket);
      }

      if (droppableIdStart !== droppableIdEnd) {
        const columnStart: any = state.columns.find(
          (column) => droppableIdStart == column.columnId
        );
        const ticket = columnStart.tickets.splice(droppableIndexStart, 1);
        const columnEnd: any = state.columns.find(
          (column) => droppableIdEnd == column.columnId
        );

        columnEnd.tickets.splice(droppableIndexEnd, 0, ...ticket);
      }

      return newState;
    }

    case EDIT_TICKET: {
      const updateColumns = state.columns.map((column) => {
        if (column.columnId === action.payload.columnId) {
          return {
            ...column,
            tickets: [...column.tickets, action.payload],
          };
        } else {
          return column;
        }
      });

      return { ...state, columns: updateColumns };
    }

    default:
      return state;
  }
};

export default BoardReducer;

import { ADD_TICKET } from "./ColumnActionConstants";

export const AddNewTicket = (columnId: number, title: string) => {
  return {
    type: ADD_TICKET,
    payload: { columnId, title }
  };
};

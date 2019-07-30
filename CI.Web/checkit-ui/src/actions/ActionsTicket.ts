import { CONSTANTS } from './Actions';

export const AddTicket = (listId: number, title: string) => {
    return {
        type: CONSTANTS.ADD_TICKET,
        payload: {listId, title}
    };
}
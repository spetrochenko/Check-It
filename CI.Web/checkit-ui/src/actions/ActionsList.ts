import { CONSTANTS } from './Actions';

export const AddList = (title: string) => {
    return {
        type: CONSTANTS.ADD_LIST,
        payload: title
    };
}
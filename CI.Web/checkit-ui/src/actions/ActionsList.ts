import { CONSTANTS } from './Actions';

export const AddList = (title: string) => {
    return {
        type: CONSTANTS.ADD_LIST,
        payload: title
    };
}

export const Sort = (droppableIdStart: any, droppableIdEnd: any, droppableIndexStart: any, droppableIndexEnd: any, draggableId: any) => {

    return {
        type: CONSTANTS.DRAG_HAPPENED,
        payload: {
            droppableIdStart,
            droppableIdEnd,
            droppableIndexStart,
            droppableIndexEnd,
            draggableId
        }
    }
}
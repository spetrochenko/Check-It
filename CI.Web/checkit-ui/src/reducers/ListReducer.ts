import { CONSTANTS } from '../actions/Actions';

let listId = 2;
let ticketId = 3

const initialState = [
    {
        title: "test1",
        id: 0,
        cards: [
            {
                id: 0,
                title: "testCard"
            },
            {
                id: 1,
                title: "testCard2"
            }
        ]
    },
    {
        title: "test2",
        id: 1,
        cards: [
            {
                id: 0,
                title: "testCardList2"
            },
            {
                id: 1,
                title: "testCard2List2"
            },
            {
                id: 2,
                title: "testCard3List3"
            }
        ]
    }
]

const ListReducer = (state = initialState, action: any) => {
    switch (action.type) {
        case CONSTANTS.ADD_LIST:
            const newList = {
                title: action.payload,
                cards: [],
                id: listId
            }
            listId += 1;

            return [...state, newList];

        case CONSTANTS.ADD_TICKET:
            const newTicket = {
                title: action.payload.title,
                id: ticketId
            }
            ticketId += 1;

            const newState = state.map(list => {
                if (list.id === action.payload.listId) {
                    return {
                        ...list,
                        cards: [...list.cards, newTicket]
                    }
                } else {
                    return list;
                }
            })

            return newState;

        default:
            return state;
    }
}

export default ListReducer;
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
                id: 3,
                title: "testCard3List3"
            }
        ]
    }
]


const ListReducer = (state = initialState, action: any) => {
    switch (action.type) {
        default:
            return state;
    }
}

export default ListReducer;
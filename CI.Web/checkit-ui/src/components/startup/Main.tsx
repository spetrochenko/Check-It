import React from 'react';
import TicketList from '../board/TicketList';
import { makeStyles } from '@material-ui/core';
import { connect } from 'react-redux';
import BoardActionButton from '../inputs/BoardActionButton';
import { DragDropContext } from 'react-beautiful-dnd';

const mapStateToProps = (state: any) => ({
    lists: state.lists
});

const useStyles = makeStyles({
    listContainer: {
        display: 'flex',
        flexDirection: 'row'
    },
    buttonContainer: {
        width: 300,
        marginTop: 23,
        padding: 7,
        height: '100%'
    }
});

export const Main = (props: any) => {

    const classes = useStyles();
    const { lists } = props;

    const onDragEnd = () => {

    }

    return (
        <DragDropContext onDragEnd={onDragEnd}>
            <div>
                <div className={classes.listContainer}>
                    {
                        lists.map((list: any) => (<TicketList listId={list.id} key={list.id} title={list.title} cards={list.cards} />))
                    }

                    <div className={classes.buttonContainer}>
                        <BoardActionButton isList={true} />
                    </div>
                </div>
            </div>
        </DragDropContext>
    )

}

export default connect(mapStateToProps)(Main);

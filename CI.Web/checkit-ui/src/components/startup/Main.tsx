import React from 'react';
import TicketList from '../board/TicketList';
import { makeStyles } from '@material-ui/core';
import { connect } from 'react-redux';
import BoardActionButton from '../inputs/BoardActionButton';

const mapStateToProps = (state: any) => ({
    lists: state.lists
});

const useStyles = makeStyles({
    listContainer: {
        display: 'flex',
        flexDirection: 'row'
    }
});

export const Main = (props: any) => {

    const classes = useStyles();
    const { lists } = props;

    return (

        <div>
            <div className={classes.listContainer}>
                {
                    lists.map((list: any) => (<TicketList key={list.id} title={list.title} cards={list.cards} />))
                }
            </div>
        </div>
    )

}

export default connect(mapStateToProps)(Main);

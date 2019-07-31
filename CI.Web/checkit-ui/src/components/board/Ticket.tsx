import React from 'react';
import Card from '@material-ui/core/Card';
import { makeStyles, CardHeader } from '@material-ui/core';
import { Draggable } from 'react-beautiful-dnd';

const useStyles = makeStyles({
    card: {
        minWidth: 275,
        margin: 10,
        transition: '0.2s',
        '&:hover': {
            backgroundColor: '#e0e0e0'
        },
        '&:active': {
            backgroundColor: '#e0e0e0'
        }
    }
});


const Ticket = (props: any) => {

    const classes = useStyles();

    return (
        <Draggable draggableId={String(props.ticketId)} index={props.index}>
            {
                (provided) => (
                    <div ref={provided.innerRef} {...provided.draggableProps} {...provided.dragHandleProps}>
                        <Card className={classes.card}>
                            <CardHeader title={props.title} subheader="Date of creation" />
                        </Card>
                    </div>
                )
            }
        </Draggable>
    )
}

export default Ticket;
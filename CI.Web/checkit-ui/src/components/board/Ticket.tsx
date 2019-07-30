import React from 'react';
import Card from '@material-ui/core/Card';
import CardActionArea from '@material-ui/core/CardActionArea';
import { makeStyles, CardHeader } from '@material-ui/core';
import { Draggable } from 'react-beautiful-dnd';

const useStyles = makeStyles({
    card: {
        minWidth: 275,
        margin: 10
    }
});


const Ticket = (props: any) => {

    const classes = useStyles();

    return (
        <Draggable draggableId={String(props.listid)} index={props.index}>
            {
                (provided) => (
                    <div ref={provided.innerRef} {...provided.draggableProps} {...provided.dragHandleProps}>
                        <Card className={classes.card}>
                            <CardActionArea>
                                <CardHeader title={props.title} subheader="Date of creation" />
                            </CardActionArea>
                        </Card>
                    </div>
                )
            }
        </Draggable>
    )
}

export default Ticket;
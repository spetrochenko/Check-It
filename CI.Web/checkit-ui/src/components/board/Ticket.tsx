import React from "react";
import Card from "@material-ui/core/Card";
import { makeStyles, CardHeader } from "@material-ui/core";
import { Draggable } from "react-beautiful-dnd";
import { TicketViewModel } from "../../models/models";

const useStyles = makeStyles({
  card: {
    minWidth: 275,
    margin: 10,
    transition: "0.2s",
    "&:hover": {
      backgroundColor: "#e0e0e0"
    },
    "&:active": {
      backgroundColor: "#e0e0e0"
    }
  }
});

interface TicketProps {
  ticketModel: TicketViewModel;
  index: any;
}

const Ticket = (props: TicketProps) => {
  const classes = useStyles();

  return (
    <Draggable
      draggableId={String(props.ticketModel.ticketId)}
      index={props.index}
    >
      {provided => (
        <div
          ref={provided.innerRef}
          {...provided.draggableProps}
          {...provided.dragHandleProps}
        >
          <Card className={classes.card}>
            <CardHeader
              title={props.ticketModel.title}
              subheader={props.ticketModel.creationDate}
            />
          </Card>
        </div>
      )}
    </Draggable>
  );
};

export default Ticket;

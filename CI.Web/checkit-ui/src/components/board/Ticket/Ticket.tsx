import React from "react";
import Card from "@material-ui/core/Card";
import { CardHeader } from "@material-ui/core";
import { Draggable } from "react-beautiful-dnd";
import { TicketViewModel } from "../../../models/models";
import { useStyles } from "./TicketStyles";

interface TicketProps {
  ticketModel: TicketViewModel;
  index: any;
  onTicketClickHandler: any
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
          <Card className={classes.card} onClick={props.onTicketClickHandler}>
            <CardHeader
              title={props.ticketModel.title}/>
          </Card>
        </div>
      )}
    </Draggable>
  );
};

export default Ticket;

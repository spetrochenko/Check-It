import React from "react";
import { Typography } from "@material-ui/core";
import { makeStyles } from "@material-ui/core/styles";
import Ticket from "../board/Ticket";
import BoardActionButton from "../inputs/BoardActionButton";
import { Droppable } from "react-beautiful-dnd";
import { ColumnViewModel, TicketViewModel } from "../../models/models";

const useStyles = makeStyles({
  container: {
    backgroundColor: "#9fa8da",
    borderRadius: 5,
    width: 300,
    marginTop: 30,
    padding: 8,
    margin: 8,
    height: "100%"
  }
});

const TicketList = (props: ColumnViewModel) => {
  const classes = useStyles();

  return (
    <Droppable droppableId={String(props.columnId)}>
      {provided => (
        <div
          {...provided.droppableProps}
          ref={provided.innerRef}
          className={classes.container}
        >
          <Typography variant="h6" component="h6">
            {props.title}
          </Typography>

          {props.tickets.map((ticket: TicketViewModel, index: any) => (
            <Ticket key={ticket.ticketId} ticketModel={ticket} index={index} />
          ))}

          <BoardActionButton columnId={props.columnId} isList={false} />

          {provided.placeholder}
        </div>
      )}
    </Droppable>
  );
};

export default TicketList;

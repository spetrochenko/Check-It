import React, { useState } from "react";
import { Typography } from "@material-ui/core";
import Ticket from "../Ticket/Ticket";
import BoardActionButton from "../../inputs/BoardActionButton";
import { Droppable } from "react-beautiful-dnd";
import { ColumnViewModel, TicketViewModel } from "../../../models/models";
import { useStyles } from "./TicketListStyles";
import TicketDetailsForm from "../Ticket/TicketDetailsForm";

const TicketList = (props: ColumnViewModel) => {
  const classes = useStyles();
  const [isOpenDialog, setOpenDialog] = useState(false);

  let ticket: TicketViewModel;

  const handleDialogOpen = (ticket: TicketViewModel) => {
    
    setOpenDialog(!isOpenDialog);
  };

  return (
    <div>
      <Droppable droppableId={String(props.columnId)}>
        {(provided) => (
          <div
            {...provided.droppableProps}
            ref={provided.innerRef}
            className={classes.container}
          >
            <Typography variant="h6" component="h6">
              {props.title}
            </Typography>

            {props.tickets.map((ticket: TicketViewModel, index: any) => (
              <Ticket
                key={ticket.ticketId}
                ticketModel={ticket}
                index={index}
                onTicketClickHandler={handleDialogOpen}
              />
            ))}

            <div>
              <BoardActionButton columnId={props.columnId} isList={false} />
            </div>

            {provided.placeholder}
          </div>
        )}
      </Droppable>

      <TicketDetailsForm
        isOpen={isOpenDialog}
        setDialogOpen={handleDialogOpen}
      />
    </div>
  );
};

export default TicketList;

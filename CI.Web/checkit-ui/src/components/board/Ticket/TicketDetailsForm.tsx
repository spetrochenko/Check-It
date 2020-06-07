import React, { useState, useEffect } from "react";
import Button from "@material-ui/core/Button";
import Dialog from "@material-ui/core/Dialog";
import DialogActions from "@material-ui/core/DialogActions";
import DialogContent from "@material-ui/core/DialogContent";
import DialogTitle from "@material-ui/core/DialogTitle";
import { connect } from "react-redux";
import { EditTicket } from "../../../actions/board/BoardActions";

const mapDispatchToProps = {
  EditTicket
};

const TicketDetailsForm = (props: any) => {
  const [open, setOpen] = useState(false);
  const { isOpen, setDialogOpen, EditTicket, ticket } = props;

  useEffect(() => {
    setOpen(isOpen);
  }, [isOpen]);

  const handleClose = () => {
    setDialogOpen(false);
  };

  const handleEdit = () => {
    if (ticket) {
      EditTicket(ticket);
    }

    setDialogOpen(false);
  };

  return (
    <div>
      <Dialog
        open={open}
        onClose={handleClose}
        aria-labelledby="form-dialog-title"
        maxWidth="xs"
      >
        <DialogTitle id="form-dialog-title">asa</DialogTitle>
        <DialogContent>
          sdsdsd
        </DialogContent>
        <DialogActions>
          <Button onClick={handleEdit} color="primary">
            Edit
          </Button>
          <Button onClick={handleClose} color="primary">
            Cancel
          </Button>
        </DialogActions>
      </Dialog>
    </div>
  );
};

export default connect(
  null,
  mapDispatchToProps
)(TicketDetailsForm);

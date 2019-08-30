import React, { useState, useEffect } from "react";
import Button from "@material-ui/core/Button";
import TextField from "@material-ui/core/TextField";
import Dialog from "@material-ui/core/Dialog";
import DialogActions from "@material-ui/core/DialogActions";
import DialogContent from "@material-ui/core/DialogContent";
import DialogTitle from "@material-ui/core/DialogTitle";
import { connect } from "react-redux";
import { AddNewBoard } from "../../../actions/board/BoardActions";
import { CreateBoardViewModel } from "../../../models/models";
import AddCircleOutlineIcon from "@material-ui/icons/AddCircleOutline";
import { useStyles } from "./CreateBoardFormStyles";

const mapDispatchToProps = {
  AddNewBoard
};

const CreateBoardForm = (props: any) => {
  const [open, setOpen] = useState(false);
  const [title, setTitle] = useState();
  const { isOpen, setDialogOpen, AddNewBoard } = props;
  const classes = useStyles();

  useEffect(() => {
    setOpen(isOpen);
  }, [isOpen]);

  const handleClose = () => {
    setDialogOpen(!isOpen);
  };

  const handleCreate = () => {
    if (title) {
      const board: CreateBoardViewModel = {
        title: title
      };

      AddNewBoard(board);
    }

    setDialogOpen(!isOpen);
  };

  return (
    <div>
      <Dialog
        open={open}
        onClose={handleClose}
        aria-labelledby="form-dialog-title"
        maxWidth="xs"
      >
        <DialogTitle id="form-dialog-title" className={classes.formTitle}>
          <AddCircleOutlineIcon />
        </DialogTitle>
        <DialogContent>
          <TextField
            autoFocus
            margin="dense"
            id="title"
            label="Title"
            type="text"
            fullWidth
            onChange={event => setTitle(event.target.value)}
          />
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCreate} color="primary">
            Create
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
)(CreateBoardForm);

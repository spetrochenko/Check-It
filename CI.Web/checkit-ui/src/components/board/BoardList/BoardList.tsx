import React, { useState } from "react";
import Button from "@material-ui/core/Button";
import { connect } from "react-redux";
import { CreateBoardViewModel } from "../../../models/models";
import { useStyles } from "./BoardListStyles";
import CreateBoardForm from "../../forms/boardForm/CreateBoardForm";

const mapStateToProps = (state: CreateBoardViewModel[]) => {
  return {
    state: state
  };
};

const BoardList = (props: any) => {
  const [isDialogOpen, setDialogOpen] = useState(false);
  const classes = useStyles();

  const handleOpenDialog = () => {
    setDialogOpen(true);
  };

  return (
    <div className={classes.container}>
      <Button onClick={handleOpenDialog} variant="contained" color="primary">
        Create board
      </Button>

      <CreateBoardForm setDialogOpen={setDialogOpen} isOpen={isDialogOpen} />
    </div>
  );
};

export default connect(mapStateToProps)(BoardList);

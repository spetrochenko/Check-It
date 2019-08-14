import React from "react";
import ActionList from "../../list/ActionsList";
import BoardList from "../../board/BoardList/BoardList";
import { useStyles } from "./MainStyles";
import Notification from "../../notification/Notification";

export const Main = () => {
  const classes = useStyles();

  return (
    <div className={classes.container}>
      <ActionList />
      <BoardList />
      <Notification />
    </div>
  );
};

export default Main;

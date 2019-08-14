import React from "react";
import { useStyles } from "./NotificationStyles";
import ListSubheader from "@material-ui/core/ListSubheader";

const Notification = () => {
  const classes = useStyles();

  return (
    <div className={classes.container}>
      <ListSubheader component="div" id="nested-list-subheader">
        Notifications
      </ListSubheader>
    </div>
  );
};

export default Notification;

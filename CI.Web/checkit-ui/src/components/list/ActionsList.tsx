import React, { useState } from "react";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import ListItemIcon from "@material-ui/core/ListItemIcon";
import ListItemText from "@material-ui/core/ListItemText";
import CreateIcon from "@material-ui/icons/AddCircle";
import GroupAddIcon from "@material-ui/icons/GroupAdd";
import GroupIcon from "@material-ui/icons/Group";
import { useStyles } from "./ActionsListStyles";
import ExpandLess from "@material-ui/icons/ExpandLess";
import ExpandMore from "@material-ui/icons/ExpandMore";
import { Collapse, ListSubheader } from "@material-ui/core";
import CreateBoardForm from "../forms/boardForm/CreateBoardForm";

const ActionList = () => {
  const classes = useStyles();
  const [isOpenDialog, setOpenDialog] = useState(false);
  const [isOpenDropDawn, setOpenDropDawn] = useState(false);

  const handleDialogOpen = () => {
    setOpenDialog(!isOpenDialog);
  };

  return (
    <div className={classes.root}>
      <List
        component="div"
        subheader={
          <ListSubheader component="div" id="nested-list-subheader">
            Settings
          </ListSubheader>
        }
      >
        <ListItem button>
          <ListItemIcon onClick={handleDialogOpen}>
            <CreateIcon />
          </ListItemIcon>
          <ListItemText primary="Add new board" onClick={handleDialogOpen} />
        </ListItem>
        <ListItem button>
          <ListItemIcon>
            <GroupAddIcon />
          </ListItemIcon>
          <ListItemText primary="Add new group" />
        </ListItem>
        <ListItem button onClick={() => setOpenDropDawn(!isOpenDropDawn)}>
          <ListItemIcon>
            <GroupIcon />
          </ListItemIcon>
          <ListItemText primary="My groups" />
          {isOpenDropDawn ? <ExpandLess /> : <ExpandMore />}
        </ListItem>
        <Collapse in={isOpenDropDawn} timeout="auto" unmountOnExit>
          <List component="div" disablePadding>
            <ListItem button className={classes.nested}>
              <ListItemText primary="Some group" />
            </ListItem>
          </List>
        </Collapse>
      </List>

      <CreateBoardForm isOpen={isOpenDialog} setDialogOpen={handleDialogOpen} />
    </div>
  );
};

export default ActionList;

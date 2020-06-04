import React, { useState } from "react";
import { connect } from "react-redux";
import { CreateBoardViewModel } from "../../../models/models";
import { useStyles } from "./BoardListStyles";
import Card from "@material-ui/core/Card";
import CardActionArea from "@material-ui/core/CardActionArea";
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";
import { ListSubheader } from "@material-ui/core";
import { NavLink } from "react-router-dom";

const mapStateToProps = (state: CreateBoardViewModel[]) => {
  return {
    state: state,
  };
};

const BoardList = (props: any) => {
  const classes = useStyles();

  const RenderTextNoBoards = () => (
    <Typography
      component="h2"
      variant="subtitle1"
      className={classes.noBoardContainer}
    >
      Oooops... You don't have any boards yet.
    </Typography>
  );

  const getPath = (title: String) => {
    return "/board/" + title.toLowerCase().replace(' ', '_');
  };

  const RenderBoards = () => {
    if (props.state.boardList.length > 0) {
      return props.state.boardList.map((item: CreateBoardViewModel) => (
        <Card className={classes.cardStyle} key={item.title}>
          <CardActionArea>
            <CardContent>
              <NavLink
                to={getPath(item.title)}
                exact
                style={{
                  textDecoration: "none",
                  color: "#000",
                }}
              >
                <Typography gutterBottom variant="h5" component="h2">
                  {item.title}
                </Typography>
              </NavLink>
            </CardContent>
          </CardActionArea>
        </Card>
      ));
    }

    return RenderTextNoBoards();
  };

  return (
    <div className={classes.container}>
      <ListSubheader component="div" id="nested-list-subheader">
        My boards
      </ListSubheader>
      <div className={classes.cardContainer}>{RenderBoards()}</div>
    </div>
  );
};

export default connect(mapStateToProps)(BoardList);

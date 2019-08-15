import React, { useState, useEffect } from "react";
import { connect } from "react-redux";
import { CreateBoardViewModel } from "../../../models/models";
import { useStyles } from "./BoardListStyles";
import Card from "@material-ui/core/Card";
import CardActionArea from "@material-ui/core/CardActionArea";
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";
import { ListSubheader } from "@material-ui/core";
import { LoadBoards } from "../../../actions/board/BoardActions";
import Preloader from "../../preloader/Preloader";

const mapStateToProps = (state: any) => {
  return {
    state: state.boardList
  };
};

const mapDispatchToProps = {
  LoadBoards
};

const BoardList = (props: any) => {
  const classes = useStyles();
  const { state, LoadBoards } = props;

  useEffect(() => {
    LoadBoards();
  }, []);

  const RenderTextNoBoards = () => (
    <Typography
      component="h2"
      variant="subtitle1"
      className={classes.noBoardContainer}
    >
      Oooops... You don't have any boards yet.
    </Typography>
  );

  const RenderBoards = () => {
    if (state.boardList.length > 0) {
      return state.boardList.map((item: CreateBoardViewModel) => (
        <Card className={classes.cardStyle} key={item.title}>
          <CardActionArea>
            <CardContent>
              <Typography gutterBottom variant="h5" component="h2">
                {item.title}
              </Typography>
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
      <div className={classes.cardContainer}>
        {state.isFetching ? <Preloader /> : RenderBoards()}
      </div>
    </div>
  );
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(BoardList);

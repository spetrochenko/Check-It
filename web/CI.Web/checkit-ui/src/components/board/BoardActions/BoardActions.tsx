import React from "react";
import Grid from "@material-ui/core/Grid";
import Paper from "@material-ui/core/Paper";
import Typography from "@material-ui/core/Typography";
import { useStyles } from "./BoardActionsStyles";

interface BoardActionProps {
  boardTitle: string;
}

const BoardActions = (props: BoardActionProps) => {
  const classes = useStyles();

  return (
    <div>
      <Paper className={classes.control}>
        <Grid container justify="flex-start" alignItems="center">
          <Grid item xs={1}>
            <Typography
              variant="h5"
              component="h5"
              className={classes.textStyle}
            >
              {props.boardTitle}
            </Typography>
          </Grid>
        </Grid>
      </Paper>
    </div>
  );
};

export default BoardActions;

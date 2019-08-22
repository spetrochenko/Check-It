import React from "react";
import { useStyles } from "./LoginStyles";
import { Typography } from "@material-ui/core";
import { Button } from "@material-ui/core";
import TextField from "@material-ui/core/TextField";
import Grid from "@material-ui/core/Grid";
import { NavLink } from "react-router-dom";

const Login = () => {
  const classes = useStyles();

  return (
    <div className={classes.container}>
      <Typography variant="h4" component="h4" className={classes.titleStyle}>
        Welcome to Check-it!
      </Typography>
      <Typography variant="subtitle1" className={classes.subTitleStyles}>
        This application will help you with time monitoring.
      </Typography>
      <Typography variant="subtitle2">Register to continue.</Typography>

      <div className={classes.margin}>
        <Grid container spacing={1} alignItems="center">
          <Grid item>
            <TextField
              id="name"
              label="Your name"
              className={classes.textSize}
            />
          </Grid>
        </Grid>
      </div>
      <div className={classes.margin}>
        <Grid container spacing={2} alignItems="center">
          <Grid item>
            <TextField
              id="email"
              label="Your email"
              className={classes.textSize}
            />
          </Grid>
        </Grid>
      </div>
      <div className={classes.margin}>
        <Grid container spacing={1} alignItems="center">
          <Grid item>
            <TextField
              id="password"
              label="Your password"
              className={classes.textSize}
              type="password"
            />
          </Grid>
        </Grid>
      </div>

      <Button
        variant="contained"
        color="primary"
        className={classes.registerButton}
      >
        <NavLink
          to="/boards"
          exact
          style={{
            textDecoration: "none",
            color: "#fff",
          }}
        >
          Try it!
        </NavLink>
      </Button>
    </div>
  );
};

export default Login;

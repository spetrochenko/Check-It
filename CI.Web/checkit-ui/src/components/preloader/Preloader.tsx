import React from "react";
import { useStyles } from "./PreloaderStyles";
import CircularProgress from "@material-ui/core/CircularProgress";

const Preloader = () => {
  const classes = useStyles();
  
  return (
    <div>
      <CircularProgress className={classes.progress} />
    </div>
  );
};

export default Preloader;

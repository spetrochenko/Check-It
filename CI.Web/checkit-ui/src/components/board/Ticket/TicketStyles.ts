import { makeStyles } from "@material-ui/core";

export const useStyles = makeStyles({
  card: {
    minWidth: 275,
    margin: 10,
    transition: "0.2s",
    "&:hover": {
      backgroundColor: "#e0e0e0"
    },
    "&:active": {
      backgroundColor: "#e0e0e0"
    }
  }
});

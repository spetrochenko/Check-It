import { makeStyles, createStyles, Theme } from "@material-ui/core";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    control: {
      width: "100%",
      height: 40,
      backgroundColor: "#e0e0e0",
      opacity: 0.5
    },
    textStyle: {
      textAlign: "center"
    }
  })
);

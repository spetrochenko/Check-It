import { makeStyles, Theme, createStyles } from "@material-ui/core";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    listContainer: {
      display: "flex",
      flexDirection: "row"
    },
    buttonContainer: {
      width: 300,
      marginTop: theme.spacing(2),
      height: "100%"
    }
  })
);

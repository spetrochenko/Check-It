import { makeStyles, Theme, createStyles } from "@material-ui/core/styles";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    container: {
      marginTop: "5%",
      marginLeft: "2%",
      width: "100%",
      maxWidth: "40%"
    }
  })
);

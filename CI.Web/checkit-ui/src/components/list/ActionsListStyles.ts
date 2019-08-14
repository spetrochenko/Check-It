import { createStyles, Theme, makeStyles } from "@material-ui/core/styles";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      marginTop: "5%",
      marginLeft: "10%",
      width: "100%",
      maxWidth: "20%",
      backgroundColor: theme.palette.background.paper
    },
    nested: {
      paddingLeft: theme.spacing(4)
    }
  })
);

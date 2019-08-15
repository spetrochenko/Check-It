import { createStyles, Theme, makeStyles } from "@material-ui/core/styles";

export const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    progress: {
      marginTop: theme.spacing(10),
      marginLeft: theme.spacing(40)
    }
  })
);

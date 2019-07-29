
import React, { Suspense } from 'react';
import { createStyles, Theme, makeStyles } from '@material-ui/core/styles';
import CircularProgress from '@material-ui/core/CircularProgress';
import Header from './Header';
import Main from './Main';
import Footer from './Footer';
import 'typeface-roboto';

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        progress: {
            margin: theme.spacing(2),
        },
    }),
);

export const App = () => {
    const classes = useStyles();

    return (
        <div>
            <Header />
            <Suspense fallback={
                <div>
                    <CircularProgress className={classes.progress} />
                </div>
            }>
                <Main />
            </Suspense>
            <Footer />
        </div>
    )
}

export default App

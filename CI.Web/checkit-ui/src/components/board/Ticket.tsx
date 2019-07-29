import React from 'react';
import Card from '@material-ui/core/Card';
import CardActionArea from '@material-ui/core/CardActionArea';
import { makeStyles, CardHeader } from '@material-ui/core';

const useStyles = makeStyles({
    card: {
        minWidth: 275,
        margin: 10
    }
});


const Ticket = (props: any) => {

    const classes = useStyles();

    return (
        <div>
            <Card className={classes.card}>
                <CardActionArea>
                    <CardHeader title={props.title} subheader="Date of creation" />
                </CardActionArea>
            </Card>
        </div>

    )
}

export default Ticket;
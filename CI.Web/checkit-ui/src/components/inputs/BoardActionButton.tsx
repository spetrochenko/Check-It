import React, { useState, useEffect } from 'react';
import { makeStyles, createMuiTheme } from '@material-ui/core';
import Typography from '@material-ui/core/Typography';
import Card from '@material-ui/core/Card';
import AddIcon from '@material-ui/icons/Add';
import Icon from '@material-ui/core/Icon';
import TextArea from 'react-textarea-autosize';
import { Button } from '@material-ui/core';
import { green } from '@material-ui/core/colors';
import { ThemeProvider } from '@material-ui/styles';


const useStyle = makeStyles({
    textAreaContainer: {
        minWidth: 275,
        margin: 10,
        minHeight: 80
    },
    textArea: {
        resize: 'none',
        width: '100%',
        outline: 'none',
        border: 'none',
        overflow: 'hidden'
    },
    button: {
        color: 'white'
    },
    addButton: {
        minWidth: 275,
        width: '100%'
    },
    cancelButton: {
        marginLeft: 8
    }
});

const theme = createMuiTheme({
    palette: {
        primary: green
    }
});

const BoardActionButton = (props: any) => {

    const classes = useStyle();
    const [isFormOpen, setFormOpen] = useState(false);
    const [text, setText] = useState();

    const buttonOptions = {
        buttonText: props.isList ? "Add another column" : "Add another ticket",
        buttonTextOpasity: props.isList ? 1 : 0.5,
        buttonTextColor: props.isList ? 'white' : 'inherit',
        buttonTextBackground: props.isList ? 'rgba(0,0,0,.15)' : 'inherit',
    }

    const formOptions = {
        placeholder: props.isList ? "Enter column title..." : "Enter ticket title...",
        buttonTitle: props.isList ? "Add column" : "Add ticket"
    }

    const handleInputChange = (event: any) => {
        setText(event.target.value);
    }

    const renderAddButton = () => {

        return (
            <div style={{ opacity: buttonOptions.buttonTextOpasity, color: buttonOptions.buttonTextColor, backgroundColor: buttonOptions.buttonTextBackground }}>
                <Button variant="contained" onClick={() => setFormOpen(true)} className={classes.addButton}>
                    <AddIcon />
                    <Typography align="center" variant="overline" >
                        {buttonOptions.buttonText}
                    </Typography>
                </Button>
            </div>
        )
    };

    const renderForm = () => {
        return (
            <div>
                <Card className={classes.textAreaContainer}>
                    <TextArea
                        placeholder={formOptions.placeholder}
                        autoFocus
                        onBlur={() => setFormOpen(false)}
                        value={text}
                        onChange={handleInputChange}
                        className={classes.textArea} />
                </Card>
                <div>
                    <ThemeProvider theme={theme}>
                        <Button variant="contained" color="primary" className={classes.button}>
                            {formOptions.buttonTitle}
                        </Button>
                        <Icon className={classes.cancelButton}>
                            close
                        </Icon>
                    </ThemeProvider>
                </div>
            </div>
        );
    }

    return isFormOpen ? renderForm() : renderAddButton();
}

export default BoardActionButton

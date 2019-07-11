import React, { Component } from 'react'

export class TestComponent extends Component<{name: string}>{

    render() {
        return <div>
            <p>{this.props.name}</p>
        </div>
    }
}

export default TestComponent;
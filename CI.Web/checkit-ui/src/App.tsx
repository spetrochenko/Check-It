import React from 'react';
import TestComponent from './components/TestComponent'
import './App.css';

const App: React.FC = () => {
  return (
    <div className="App">
        <TestComponent name="test"/>
    </div>
  );
}

export default App;

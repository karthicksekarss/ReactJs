import React from 'react';
import './App.css';

import Header from "./components/header/Header";
import Home from "./components/home/Home";
import Footer from "./components/footer/Footer";
import NavBar from './components/navbar/NavBar';
import { Router, Routes, Route, BrowserRouter } from 'react-router-dom';
import About from './components/about/About';
import Contact from './components/contact/Contact';
import Student from './components/student';


function App() {
  return (
    <div className="App">
      <Header title="React App with Redux Saga" subtitle="Type Script Template" />

      <BrowserRouter>
        <NavBar />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="/student" element={<Student />} />
        </Routes>
      </BrowserRouter>


      <Footer note="Footer" />
    </div>
  );
}

export default App;

import React, { Component } from "react";
import {  Link } from "react-router-dom";




class Header extends Component {
  state = {};
  handleClick() {
    console.log("Hii");
  }
  render() {
    return (
      <div className="App">
        <nav className="navbar navbar-dark bg-primary">
          <span className="navbar-brand mb-0 h1">
            <h1>Post Your Blog</h1>
          </span>
          <button>
            <Link path="/NewForm" to="/NewForm">
              Post
            </Link>
          </button>
        </nav>
      </div>
    );
  }
}

export default Header;

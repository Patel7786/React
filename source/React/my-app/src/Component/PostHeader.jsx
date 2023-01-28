import React, { Component } from 'react'
import { NavLink ,Link} from 'react-router-dom';
import BlogPostForm from '../BlogPostForm';
import { useHistory } from "react-router-dom";
import Form from './NewForm';

class PostHeader extends Component {
    state = {  } 

    render() { 
        return (<div className='App'>
        
        <nav className='navbar navbar-dark bg-primary'>
        <span className="navbar-brand mb-0 h1"><h1>Post Your Blog</h1></span>
        <button><Link activeClassName="active" to="/">Back to Home</Link></button>
        
      
        </nav>
    </div>);
    }
}
 
export default PostHeader;






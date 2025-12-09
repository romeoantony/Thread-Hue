import React, { useState, useEffect } from 'react';

const Navbar = () => {
  const [scrolled, setScrolled] = useState(false);

  useEffect(() => {
    const handleScroll = () => setScrolled(window.scrollY > 50);
    window.addEventListener('scroll', handleScroll);
    return () => window.removeEventListener('scroll', handleScroll);
  }, []);

  return (
    <nav className={`navbar ${scrolled ? 'scrolled' : ''}`}>
      <div className="container navbar-content">
        <div className="logo">THREAD & HUE</div>
        <div className="nav-links">
          <a href="#">Shop</a>
          <a href="#">Collections</a>
          <a href="#">About</a>
        </div>
        <div className="nav-actions">
          <button>Cart (0)</button>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;

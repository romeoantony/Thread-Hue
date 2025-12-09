import React from 'react';

const products = [
  { id: 1, name: 'Oversized Tee', price: '₹3,500', image: 'https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?q=80&w=1000&auto=format&fit=crop' },
  { id: 2, name: 'Pleated Trousers', price: '₹6,500', image: 'https://images.unsplash.com/photo-1473966968600-fa801b869a1a?q=80&w=1000&auto=format&fit=crop' },
  { id: 3, name: 'Wool Coat', price: '₹18,000', image: 'https://images.unsplash.com/photo-1539533018447-63fcce2678e3?q=80&w=1000&auto=format&fit=crop' },
  { id: 4, name: 'Leather Boots', price: '₹12,000', image: 'https://images.unsplash.com/photo-1638247025967-b4e38f787b76?q=80&w=1000&auto=format&fit=crop' },
];

const ProductGrid = () => {
  return (
    <section className="product-section">
      <div className="container">
        <div className="section-header">
          <h2>FEATURED</h2>
          <a href="#" className="view-all">View All</a>
        </div>
        <div className="product-grid">
          {products.map(product => (
            <div key={product.id} className="product-card">
              <div className="product-image">
                <img src={product.image} alt={product.name} />
                <div className="product-overlay">
                  <button className="btn btn-white">Quick View</button>
                </div>
              </div>
              <div className="product-info">
                <h3>{product.name}</h3>
                <p>{product.price}</p>
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
};

export default ProductGrid;

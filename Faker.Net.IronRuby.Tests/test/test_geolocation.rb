require 'helper'


class TestGeolocation < Test::Unit::TestCase

  def test_lat
    assert_match /[0-9]+/, Faker::GeoLocation.lat.to_s
  end

  def test_lng
    assert_match /[0-9]+/, Faker::GeoLocation.lng.to_s
  end
end